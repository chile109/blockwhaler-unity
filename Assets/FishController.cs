using UnityEngine;
using System.Collections;
using TMPro;
using System.Collections.Generic;
using System.Runtime.InteropServices;


public class FishController : MonoBehaviour
{
    // --- UI ---
        private int bounty = 1000;
        [SerializeField] private TextMeshProUGUI bountyText;

        [DllImport("__Internal")]
        private static extern void ShootCallback();

        public void UpdateBounty()
        {
            bounty += 10;
            bountyText.text = "Current Bounty: " + bounty.ToString() + " LINK";

            #if UNITY_WEBGL == true && UNITY_EDITOR == false
                ShootCallback ();
            #endif
        }
}
