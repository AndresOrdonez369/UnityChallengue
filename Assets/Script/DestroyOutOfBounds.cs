using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 27f;
    private float botBound = -24f;
    private float leftBound = -24f;
    private float rightBound = 24f;
    private Text text;
    
    // Start is called before the first frame update
    void Awake()
    {
        // Load the Arial font from the Unity Resources folder.
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        // Create Canvas GameObject.
        GameObject canvasGO = new GameObject();
        canvasGO.name = "Canvas";
        canvasGO.AddComponent<Canvas>();
        canvasGO.AddComponent<CanvasScaler>();
        canvasGO.AddComponent<GraphicRaycaster>();

        // Get canvas from the GameObject.
        Canvas canvas;
        canvas = canvasGO.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        // Create the Text GameObject.
        GameObject textGO = new GameObject();
        textGO.transform.parent = canvasGO.transform;
        textGO.AddComponent<Text>();

        // Set Text component properties.
        text = textGO.GetComponent<Text>();
        text.font = arial;
        text.text = "";
        text.fontSize = 40;
        text.alignment = TextAnchor.MiddleCenter;

        // Provide Text position and size using RectTransform.
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 0, 50);
        rectTransform.sizeDelta = new Vector2(400, 200);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.z > topBound
            || this.transform.position.x < leftBound
            || this.transform.position.x > rightBound)
        {
            Destroy(this.gameObject); 
        }
        if (this.transform.position.z < botBound)
        {
             
            text.text = "GAME OVER";
            Destroy(this.gameObject);
            Time.timeScale = 0;
        }

    }
}
