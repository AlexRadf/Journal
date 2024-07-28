using UnityEngine;

public class TriggerBox : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    private Color triggeredColor = Color.red; // Color to change to when triggered

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    public void TriggerAction()

    {

        Debug.Log("TriggerAction called on: " + gameObject.name);

        // Flip-flop the color between original and triggered color
        if (spriteRenderer.color == originalColor)
        {
            spriteRenderer.color = triggeredColor;
        }
        else
        {
            spriteRenderer.color = originalColor;
        }
    }
}
