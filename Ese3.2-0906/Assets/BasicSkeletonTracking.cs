using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicSkeletonTracking : MonoBehaviour
{
    public Text text;
   // public nuitrack.JointType[] typeJoint; // joint da individuare
    // public GameObject prefabJoint; // marker che vogliamo usare per visualizzarli

   // GameObject[] createdJoint; // lista di marker riposizionati per ogni frame
    // Start is called before the first frame update
    void Start()
    {
        //createdJoint = new GameObject[typeJoint.Length]; // creo la lista vuota
        //for (int i = 0; i < typeJoint.Length; i++) //popolo la lista di tanti elementi quanti i joint creo il markatore i esimo
        {
            //createdJoint[i] = Instantiate(prefabJoint);
            //createdJoint[i].transform.SetParent(this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (NuitrackManager.Users.CurrentUserID != 0) // esiste almeno uno skeleton
        {
            text.text = "trovato";
            
           // NuitrackSDK.UserData.SkeletonData skeleton = NuitrackManager.Users.Current.Skeleton; // ne metto i dati in skeleton

           // for (int i = 0; i < typeJoint.Length; i++) // percorro lo scheletro recuperando i dati del singolo giunto
            {
               // NuitrackSDK.UserData.SkeletonData.Joint joint = skeleton.GetJoint(typeJoint[i]);
                //Vector3 pos = joint.Position * 10f; // creo un oggetto pos con i dati di posizione del giunto
                //createdJoint[i].transform.localPosition = pos; // lo uso per aggiornare il marker relativo
            }
        }
        else
        {
            text.text = "non trovato";
        }
        
    }
}
