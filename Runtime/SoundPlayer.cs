using System;
using Postive.SimpleSoundAssetManager.Runtime.Attributes;
using UnityEngine;

namespace Postive.SimpleSoundAssetManager.Runtime
{
    [Serializable]
    public class SoundPlayer
    {
        public string SoundName {
            get => _soundName;
            set => _soundName = value;
        }
        [SoundSelector]
        [SerializeField] private string _soundName = "NONE";
        public void PlaySound() {
            SoundManager.PlaySound(_soundName);
        }
        public void PlaySound(Vector3 position) {
            SoundManager.PlaySound(_soundName, position);
        }
        public void PlaySound(Transform transform){
            SoundManager.PlaySound(_soundName, transform);
        }
    }
}