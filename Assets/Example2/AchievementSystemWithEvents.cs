using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystemWithEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();

        //Method name at the end needs to have the same parameters as the action in PointOfInterestWithEvents
        PointOfInterestWithEvents.OnPointOfInterestEntered += PointOfInterestWithEvents_OnPointOfInterestEntered;
    }

    private void PointOfInterestWithEvents_OnPointOfInterestEntered(PointOfInterestWithEvents poi)
    {
        string achievementKey = "achievement-" + poi.PoiName;

        if (PlayerPrefs.GetInt(achievementKey) == 1)
            return;

        PlayerPrefs.SetInt(achievementKey, 1);
        Debug.Log("Unlocked " + poi.PoiName);
        //Send stuff to steam
    }

    private void OnDestroy()
    {
        //Totally not necessary for this game, but good practice to avoid conflicts.
        PointOfInterestWithEvents.OnPointOfInterestEntered -= PointOfInterestWithEvents_OnPointOfInterestEntered;
    }
}
