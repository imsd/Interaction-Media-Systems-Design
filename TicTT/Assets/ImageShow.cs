 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 public class ImageShow : MonoBehaviour {
 
     public bool isImgOn;
     public Texture o;
     public Texture x;
     public string WhichKey1; 
     public string WhichKey2; 
        public Renderer rend;
 
     void Start () {
         rend = GetComponent<Renderer>();
 
         rend.material.mainTexture = o;

         
     }
 
     void Update () {
     
         if (Input.GetKeyDown (WhichKey1)) {
             rend.material.mainTexture = o;
             }

            if (Input.GetKeyDown (WhichKey2)) {
                rend.material.mainTexture = x;
             }


             }
 }
 