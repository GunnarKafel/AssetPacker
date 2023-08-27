using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace AssetPacker
{
	public class AddonPacker
	{
		public struct PackerInfo
		{
			public ProgressBar ProgressBar;
			public string AddonPath;
			public string AddonName => (AddonPath.Substring(AddonPath.LastIndexOf('\\')));
			public string AddonSuffix;
			public string PackedAddonsPath;
			public Int64 MaxSize;
			public bool DeleteVrad3;
			public bool DeleteBakedResourceCache;
			public bool DeleteScreenshots;
			public bool DeleteSourceFilmmakerElements;
			public bool DeleteSaves;
		}

		private PackerInfo packerInfo;
		private List<string> excludedFiles;

		public AddonPacker(PackerInfo info)
		{
			packerInfo = info;

			SetupExcludedFiles();
		}

		private Int64 GetUnpackedAddonSize()
		{
			var directory = new DirectoryInfo(packerInfo.AddonPath);
			var files = directory.GetFiles("*", SearchOption.AllDirectories);

			Int64 total = 0;
			foreach (var file in files)
			{
				total += file.Length;
			}

			return total;
		}

		private void SetupExcludedFiles()
		{
			excludedFiles = new List<string>();

			if (packerInfo.DeleteVrad3)
				excludedFiles.Add($"{packerInfo.AddonPath}\\_vrad3\\");

			if (packerInfo.DeleteBakedResourceCache)
				excludedFiles.Add($"{packerInfo.AddonPath}\\_bakeresourcecache\\");

			if (packerInfo.DeleteScreenshots)
				excludedFiles.Add($"{packerInfo.AddonPath}\\screenshots\\");

			if (packerInfo.DeleteSourceFilmmakerElements)
				excludedFiles.Add($"{packerInfo.AddonPath}\\elements\\");

			if (packerInfo.DeleteSaves)
				excludedFiles.Add($"{packerInfo.AddonPath}\\save\\");

			excludedFiles.Add($"{packerInfo.AddonPath}\\resourcemanifests\\");
			excludedFiles.Add($"{packerInfo.AddonPath}\\soundevents\\");
			excludedFiles.Add($"{packerInfo.AddonPath}\\tools_asset_info.bin");
			excludedFiles.Add($"{packerInfo.AddonPath}\\tools_thumbnail_cache.bin");
		}

		private string GetAddonName()
		{
			var rootLength = packerInfo.PackedAddonsPath.Length;
			return packerInfo.AddonPath.Substring(rootLength);
		}

		public void Run()
		{
			var addonDirectory = new DirectoryInfo(packerInfo.AddonPath);
			Int64 addonSize = Convert.ToInt64(packerInfo.MaxSize);
			Int64 remainingSize = addonSize;

			var itemsToPack = addonDirectory
				.GetFiles("*", SearchOption.AllDirectories)
				.OrderBy(file => -file.Length);

			packerInfo.ProgressBar.Maximum = itemsToPack.Count();
			packerInfo.ProgressBar.Step = 1;

			int partIndex = 0;
			Int64 currentPartSize = 0;

			var firstPartSize = CreateFirstPart();

			if (firstPartSize > packerInfo.MaxSize)
			{
				MessageBox.Show($"Resource Manifests, Soundevents, and addoninfo.txt over max part size! {firstPartSize / 1e9} / {packerInfo.MaxSize / 1e9}", "Part 0 over max size!", MessageBoxButton.OK, MessageBoxImage.Warning);
			}

			currentPartSize += firstPartSize;

			foreach (var file in itemsToPack)
			{
				if (file.Length > packerInfo.MaxSize)
				{
					MessageBox.Show($"{file.Name} ({file.Length / 1e9}GB) is greater than {packerInfo.MaxSize / 1e9}GB. We can't pack this!", "File over max size!", MessageBoxButton.OK, MessageBoxImage.Error);
					return;
				}

				bool shouldContinue = false;
				foreach (var excludeKey in excludedFiles)
				{
					if (file.FullName.Contains(excludeKey))
						shouldContinue = true;
				}
				if (shouldContinue)
					continue;

				if (currentPartSize + file.Length > packerInfo.MaxSize)
				{
					partIndex++;
					currentPartSize = 0;
					MakeAddonInfo(partIndex);
				}

				CopyToPart(file, partIndex);
				currentPartSize += file.Length;
				packerInfo.ProgressBar.PerformStep();
			}

			packerInfo.ProgressBar.Value = packerInfo.ProgressBar.Maximum;
		}

		private void CopyToPart(FileInfo file, int index)
		{
			var newDirectory = GetDirectoryInNewPart(file, index);

			if (!Directory.Exists(newDirectory))
				Directory.CreateDirectory(newDirectory);

			var fullPath = $"{newDirectory}/{file.Name}";
			if (File.Exists(fullPath))
				return;

			file.CopyTo(fullPath);
		}

		private string GetDirectoryInNewPart(FileInfo file, int partIndex)
		{
			var partPath = GetPartPath(partIndex);
			var directoryFromRoot = file.DirectoryName.Substring(packerInfo.AddonPath.Length);
			var newDirectory = $"{partPath}/{directoryFromRoot}";

			return newDirectory;
		}

		private string GetPartPath(int index)
		{
			return $"{packerInfo.PackedAddonsPath}\\{packerInfo.AddonName}{packerInfo.AddonSuffix}{index}";
		}

		/// <summary>
		/// Special case, copies Resource Manifests, Soundevent files, and addoninfo.txt directly
		/// </summary>
		private Int64 CreateFirstPart()
		{
			List<FileInfo> files = new List<FileInfo>();
			var manifestsDirectory = new DirectoryInfo(packerInfo.AddonPath + "/resourcemanifests");
			var soundEventsDirectory = new DirectoryInfo(packerInfo.AddonPath + "/soundevents");
			var addonDirectory = new DirectoryInfo(packerInfo.AddonPath);

			var manifests = manifestsDirectory.GetFiles("*", SearchOption.AllDirectories);
			var soundEvents = soundEventsDirectory.GetFiles("*", SearchOption.AllDirectories);
			var addonInfo = addonDirectory.GetFiles("*", SearchOption.TopDirectoryOnly).Where(file => file.Name.Contains("addoninfo"));

			files.AddRange(manifests);
			files.AddRange(soundEvents);
			files.AddRange(addonInfo);

			Int64 totalSize = 0;
			foreach (var file in files)
			{
				totalSize += file.Length;

				var directoryInPart = GetDirectoryInNewPart(file, 0);

				if (!Directory.Exists(directoryInPart))
				{
					Directory.CreateDirectory(directoryInPart);
				}

				var filePath = $"{directoryInPart}/{file.Name}";

				if (File.Exists(filePath))
					continue;

				file.CopyTo($"{directoryInPart}/{file.Name}");
			}

			return totalSize;
		}

		private void MakeAddonInfo(int index)
		{
			string addonInfo = "<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->{\nHideInTools = false\nIsPlayable = true\nIsTemplate = false\nmaps =\n[\n]\nmap_extensions = [  ]\n}";
			var partPath = GetPartPath(index);

			if (!Directory.Exists(partPath))
			{
				Directory.CreateDirectory(partPath);
			}

			File.WriteAllText(GetPartPath(index) + "/addoninfo.txt", addonInfo);
		}
	}
}
