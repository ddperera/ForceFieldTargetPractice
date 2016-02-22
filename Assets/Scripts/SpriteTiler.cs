using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(GravityFieldBehaviour))]
public class SpriteTiler : MonoBehaviour {

    public float gridX = 0.0f;
    public float gridY = 0.0f;

    public Sprite[] directionSprites;
    public Sprite borderSprite;

    SpriteRenderer sprite;
    GravityFieldBehaviour gfb;

    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        gfb = GetComponent<GravityFieldBehaviour>();

        switch (gfb.fieldDir)
        {
            case GravityFieldBehaviour.Direction.UP:
                sprite.sprite = directionSprites[0];
                break;
            case GravityFieldBehaviour.Direction.DOWN:
                sprite.sprite = directionSprites[1];
                break;
        }

        Vector2 spriteSize = new Vector2(sprite.bounds.size.x / transform.localScale.x, sprite.bounds.size.y / transform.localScale.y);
        Vector3 scale = Vector3.one;

        if (0.0f != gridX)
        {
            float width = Mathf.RoundToInt(sprite.bounds.size.x) / gridX;
            scale.x = width / spriteSize.x;
            spriteSize.x = width;
        }

        if (0.0f != gridY)
        {
            float height = Mathf.RoundToInt(sprite.bounds.size.y) / gridY;
            scale.y = height / spriteSize.y;
            spriteSize.y = height;
        }

        GameObject childPrefab = new GameObject();
        SpriteRenderer childSprite = childPrefab.AddComponent<SpriteRenderer>();
        childPrefab.transform.position = transform.position;
        childSprite.sprite = sprite.sprite;

        GameObject child;
        for (int i = 0, h = Mathf.RoundToInt(sprite.bounds.size.y); i * spriteSize.y < h; i++)
        {
            for (int j = 0, w = Mathf.RoundToInt(sprite.bounds.size.x); j * spriteSize.x < w; j++)
            {
                child = Instantiate(childPrefab) as GameObject;
                child.transform.position = transform.position - (new Vector3(spriteSize.x * j, spriteSize.y * i, 0));
                child.transform.localScale = scale;
                child.transform.parent = transform;
            }
        }

        Destroy(childPrefab);
        sprite.sprite = borderSprite;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
