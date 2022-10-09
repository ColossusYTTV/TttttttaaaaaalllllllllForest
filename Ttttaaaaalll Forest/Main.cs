
using BepInEx;
using UnityEngine;

namespace Colossal
{
    [BepInPlugin("org.ColossusYTTV", "TttttaaaallllForest", "1.0.0")]
    public class Main : BaseUnityPlugin
    {
        private void OnEnable()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            HarmonyPatches.RemoveHarmonyPatches();
        }

        public bool Done;
        private GameObject KickTrigger;
        private void Update()
        {
            if (!Done)
            {
                Done = true;

                GameObject monk = GameObject.Find("Player");
                monk.transform.position = new Vector3(0.2f, 1, -5);

                KickTrigger = GameObject.Find("QuitBox");
                KickTrigger.SetActive(false);
                GameObject.Find("Level").transform.localScale = new Vector3(1f, 50, 1);
            }
            else
            {
                Done = false;
            }
        }
    }
}
