using System;
using UnityEngine;

namespace Wowsome.Ads {
  public class AppLovinInterstitial : MonoBehaviour, IInterstitial {
    [Serializable]
    public struct Model {
      public string unitId;
      public int showOrder;
    }

    public Model data;

    #region IInterstitial

    public int Order => data.showOrder;

    public bool ShowInterstitial() {
      Debug.Log("show applovin ads intertitial");

#if !UNITY_EDITOR
      AppLovin.ShowInterstitial();
#endif
      return true;
    }

    public void InitInterstitial() {
      Debug.Log("init applovin");

#if !UNITY_EDITOR
      AppLovin.SetSdkKey(data.unitId.Trim());
      AppLovin.InitializeSdk();
#endif
    }

    public void UpdateInterstitial(float dt) { }

    #endregion
  }
}
