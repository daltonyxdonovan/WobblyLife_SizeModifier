using BepInEx;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;
using JetBrains.Annotations;
using System.Collections.Generic;
using System.Linq;

namespace WobblyLife_SizeModifier
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {

        float size = 1f;

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }

        public GameObject GetPlayerCharacter()
        {
            return GameObject.FindGameObjectsWithTag("Player")[0];
        }

        public PlayerController GetPlayer()
        {
            return FindObjectOfType<PlayerController>();
        }

        public void Update()
        {

            if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                size += 0.1f;
                GetPlayerCharacter().transform.localScale = new Vector3(size, size, size);
            }

            if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Alpha2))
            {
                size -= 0.1f;
                GetPlayerCharacter().transform.localScale = new Vector3(size, size, size);
            }

            if (Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                size += 0.1f;
                GetPlayerCharacter().transform.localScale = new Vector3(size, size, size);
            }

            if (Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Alpha2))
            {
                size -= 0.1f;
                GetPlayerCharacter().transform.localScale = new Vector3(size, size, size);
            }
        }

    }
}
