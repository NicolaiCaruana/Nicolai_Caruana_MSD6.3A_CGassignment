using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using Firebase.Extensions;
using Firebase.Storage;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

[Serializable]
public class ObjectInstance
{
    public string _instanceName;
    public string _shapeName;
    public string _instancePosition;
    public string _instanceCreatedDateTime;

    public ObjectInstance(string instanceName, string shapeName, string instancePosition, string instanceCreatedDateTime)
    {
        this._instanceName = instanceName;
        this._shapeName = shapeName;
        this._instancePosition = instancePosition;
        this._instanceCreatedDateTime = instanceCreatedDateTime;
    }
}

public class FirebaseController : MonoBehaviour
{
    private static DatabaseReference _dbRef;
    public static string objID;

    // Start is called before the first frame update
    void Start()
    {
        _dbRef = FirebaseDatabase.DefaultInstance.RootReference;
        DontDestroyOnLoad(this.gameObject);
    }

    public static IEnumerator CreateObject()
    {
        ObjectInstance obj1 = new ObjectInstance("Player1", "Square", "1,0", "11/11/2011");
        objID = _dbRef.Child("Objects").Child("UniqueID").Push().Key;

        Debug.Log("Done and Saved to " + _dbRef.ToString());
        yield return _dbRef.Child("Objects").Child(objID).SetRawJsonValueAsync(JsonUtility.ToJson(obj1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
