using Postive.SimpleSoundAssetManager.Runtime.Attributes;
using UnityEngine;

namespace Postive.SimpleSoundAssetManager.Runtime
{
    public class SoundPlayerComponent : MonoBehaviour
    {
        [SerializeField] private SoundPlayer _soundPlayer = new SoundPlayer();
        public void PlaySound() {
            _soundPlayer.PlaySound(transform.position);
        }
        public void PlaySoundAtTransform() {
            _soundPlayer.PlaySound(transform);
        }
        public void PlaySoundByName(string soundName) {
            _soundPlayer.SoundName = soundName;
            _soundPlayer.PlaySound(transform.position);
        }
        public void PlaySoundByNameAnim(AnimationEvent animationEvent) {
            if (animationEvent.animatorClipInfo.weight < 0.1f) return;
            _soundPlayer.SoundName = animationEvent.stringParameter;
            _soundPlayer.PlaySound(transform.position);
        }
    }
}