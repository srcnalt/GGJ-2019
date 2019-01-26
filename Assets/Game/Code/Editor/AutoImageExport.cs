using UnityEditor;
using UnityEngine;

namespace Game.Code.Editor
{
    public class AutoImageExport : AssetPostprocessor
    {
        private void OnPreprocessTexture()
        {
            var importer = (TextureImporter) assetImporter;
            
            Debug.Log(importer.name);
            
            if (!importer.assetPath.Contains("Items")) return;
        
            importer.filterMode = FilterMode.Point;
            importer.textureType = TextureImporterType.Sprite;
            importer.compressionQuality = 0;
            importer.crunchedCompression = false;
        }
    }
}
