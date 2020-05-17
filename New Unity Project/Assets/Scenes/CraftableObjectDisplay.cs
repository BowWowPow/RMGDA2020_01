using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftableObjectDisplay : MonoBehaviour
{
    public CraftableObject craftableObject;
    public List<CraftableObject> listOfObjects = new List<CraftableObject>();
    private float x, y, z = 0f;
    public float offset = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        foreach(CraftableObject i in listOfObjects)
        {
            //listOfObjects.Add(Instantiate(i, new Vector3(x + offset,y,z),Quaternion.identity));
           CraftableObject temp = ScriptableObject.CreateInstance<CraftableObject>();
           listOfObjects.Add(temp);
            temp.objname = "Pull Value From Spreadsheet";
            //Add all info to your object.
            //Store it.

        }
        //listOfObjects.Add(Instantiate())
    }


}
