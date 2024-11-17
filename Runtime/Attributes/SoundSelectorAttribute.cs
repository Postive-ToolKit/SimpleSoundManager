using Postive.CategorizedDB.Runtime.Categories.Interfaces;
using Runtime.Attributes;

namespace Postive.SimpleSoundAssetManager.Runtime.Attributes
{
    public class SoundSelectorAttribute : CategoryElementSelectorAttribute {
        public override ICategoryElementFinder ElementFinder => SoundDB.Instance;
    }
}