using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler : MonoBehaviour
    {

        public Rigidbody2D bullet;
        public Transform firePoint;
        public AudioClip GunSound;
        public string Name;

        private AudioSource source;
        private void Awake()
        {
            
                source = GetComponent<AudioSource>();
            
        }
        void OnEnable()
        {

        }

        public void SetDownState()
        {
            CrossPlatformInputManager.SetButtonDown(Name);
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            source.PlayOneShot(GunSound);
        }


        public void SetUpState()
        {
            CrossPlatformInputManager.SetButtonUp(Name);
        }


        public void SetAxisPositiveState()
        {
            CrossPlatformInputManager.SetAxisPositive(Name);
        }


        public void SetAxisNeutralState()
        {
            CrossPlatformInputManager.SetAxisZero(Name);
        }


        public void SetAxisNegativeState()
        {
            CrossPlatformInputManager.SetAxisNegative(Name);
        }

        public void Update()
        {

        }
    }
}
