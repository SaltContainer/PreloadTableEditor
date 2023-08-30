using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreloadTableEditor.Data.Converters
{
    public class ContainerConverter
    {
        public static List<Data.Container> ConvertAssetBundleToContainers(JSON.Data.AssetBundle assetBundle)
        {
            List<Data.Container> containers = new List<Container>();
            foreach (var jsonContainer in assetBundle.Container)
            {
                Data.Container container = new Data.Container();
                container.Name = jsonContainer.Name;
                container.Assets = new List<Data.UnityFile>();
                container.MainAsset = new Data.UnityFile()
                {
                    FileID = jsonContainer.Info.Asset.FileID,
                    PathID = jsonContainer.Info.Asset.PathID,
                };

                long index = jsonContainer.Info.PreloadIndex;
                long size = jsonContainer.Info.PreloadSize;
                for (long i = index; i < index + size && i < assetBundle.PreloadTable.Count; i++)
                {
                    container.Assets.Add(new Data.UnityFile()
                    {
                        FileID = assetBundle.PreloadTable[(int)i].FileID,
                        PathID = assetBundle.PreloadTable[(int)i].PathID
                    });
                }
                containers.Add(container);
            }
            return containers;
        }

        public static void UpdateContainersToAssetBundle(JSON.Data.AssetBundle assetBundle, List<Data.Container> containers)
        {
            assetBundle.Container.Clear();
            assetBundle.PreloadTable.Clear();

            long index = 0;
            foreach (var container in containers)
            {
                if (container.Assets.Count == 0)
                {
                    continue;
                }

                JSON.Data.Container bundleContainer = new JSON.Data.Container();
                bundleContainer.Name = container.Name;
                bundleContainer.Info = new JSON.Data.AssetInfo();
                bundleContainer.Info.PreloadIndex = index;
                bundleContainer.Info.PreloadSize = container.Assets.Count;
                bundleContainer.Info.Asset = new JSON.Data.UnityFile()
                {
                    FileID = container.MainAsset.FileID,
                    PathID = container.MainAsset.PathID
                };

                foreach (var asset in container.Assets)
                {
                    assetBundle.PreloadTable.Add(new JSON.Data.UnityFile()
                    {
                        FileID = asset.FileID,
                        PathID = asset.PathID
                    });
                }
                index += container.Assets.Count;

                assetBundle.Container.Add(bundleContainer);
            }
        }
    }
}
