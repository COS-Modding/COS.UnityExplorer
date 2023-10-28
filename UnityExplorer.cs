using COSML.Modding;
using UnityEngine;

namespace UnityExplorer
{
    public class UnityExplorer : Mod
    {
        public override string GetVersion() => typeof(ExplorerStandalone).Assembly.GetName().Version.ToString();

        public UnityExplorer() : base("Unity Explorer") { }

        private GameObject ueGo;
        internal static UnityExplorer Instance;
        private bool isInitialized = false;

        public override void Init()
        {
            Instance = this;
            if (ueGo != null) return;

            ueGo = new GameObject("COS_UnityExplorer");
            Object.DontDestroyOnLoad(ueGo);
            ueGo.AddComponent<KeyboardMono>();
        }

        internal void InitExplorer()
        {
            if (isInitialized) return;

            isInitialized = true;
            ExplorerStandalone.CreateInstance();
        }
    }
}