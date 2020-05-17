using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CraftableObject : ScriptableObject
{
    public string objname;
    public int maxQuantity;
    public int currentQuanity;
    public Sprite objectsprite;
    public GameObject particle;
    public AudioClip sound;
    public int levelUnlock;
    public string conditionUnlock;
}
