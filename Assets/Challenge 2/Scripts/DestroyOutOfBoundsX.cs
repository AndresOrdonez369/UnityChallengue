using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -33;
    private float bottomLimit = -2;
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
        text.color = Color.black;

        // Provide Text position and size using RectTransform.
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 0, 50);
        rectTransform.sizeDelta = new Vector2(400, 200);
    }
    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
       if (transform.position.y < bottomLimit)
        {
            text.text = "GAME OVER";
            Destroy(gameObject);
            Time.timeScale = 0;
            
        }

    }
}
