using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetPacker
{
    public class AddonPacker 
    {
        private string addonPath;
        private string addonName;
        private string cfgPath;
        private string packedAddonsPath;
        private string addonSuffix;
        private long addonMaxSize;
        private bool deleteVrad3;
        private bool deleteBakedResourceCache;
        private bool copySoundManifest;

        public AddonPacker(string AddonPath, string CfgPath, string PackedAddonsPath, string AddonSuffix, string AddonMaxSize, bool DeleteVrad3, bool DeleteBakedResourceCache, bool CopySoundManifest)
        {
            addonPath = AddonPath;
            cfgPath = CfgPath;
            packedAddonsPath = PackedAddonsPath;
            addonName = GetAddonName();
            addonSuffix = AddonSuffix;
            addonMaxSize = Convert.ToInt64(AddonMaxSize) * (int)1e9;
            deleteVrad3 = DeleteVrad3;
            deleteBakedResourceCache = DeleteBakedResourceCache;
            copySoundManifest = CopySoundManifest;
        }

        private string GetAddonName()
        {
            var rootLength = packedAddonsPath.Length;
            return addonPath.Substring(rootLength);
        }

        public void Run()
        {
            var addonDirectory = new DirectoryInfo(addonPath);
            Int64 addonSize = Convert.ToInt64(addonMaxSize);
            Int64 remainingSize = addonSize;

            var itemsToPack = addonDirectory.GetFiles("*", SearchOption.AllDirectories).OrderBy(file => -file.Length);

            int partIndex = 0;
            Int64 partSize = 0;
            foreach (var file in itemsToPack)
            {
                if (partSize + file.Length > addonMaxSize)
                {
                    partIndex++;
                    partSize = 0;
                    MakeAddonInfo(partIndex);
                }

                partSize += file.Length;
                CopyToPart(file, partIndex);
            }
        }

        private void CopyToPart(FileInfo file, int index)
        {
            var partPath = GetPartPath(index);
            var directoryFromRoot = file.DirectoryName.Substring(addonPath.Length);
            var newDirectory = $"{partPath}/{directoryFromRoot}";

            if (!Directory.Exists(newDirectory))
                Directory.CreateDirectory(newDirectory);

            var fullPath = $"{newDirectory}/{file.Name}";
            if (File.Exists(fullPath))
                return;

            file.CopyTo(fullPath);
        }

        private string GetPartPath(int index)
        {
            return $"{packedAddonsPath}/{addonName}{addonSuffix}{index}";
        }

        private void MakeAddonInfo(int index)
        {
            string addonInfo = "<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:generic:version{7412167c-06e9-4698-aff2-e63eb59037e7} -->{\nHideInTools = false\nIsPlayable = true\nIsTemplate = false\nmaps =\n[\n]\nmap_extensions = [  ]\n}";
            var partPath = $"{packedAddonsPath}/{addonName}{addonSuffix}{index}";
            File.WriteAllText(GetPartPath(index) + "/addoninfo.txt", addonInfo);        
        }
    }
}
