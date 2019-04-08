using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour
{
    public GameObject content;
    public GameObject buttonprefab;


    // Start is called before the first frame update
    void Start()
    {
        int index = 0;
        foreach(item i in PlayerStats.inventory)
        {
            var x = Instantiate<GameObject>(buttonprefab);
            x.transform.SetParent(content.transform);
            x.GetComponentsInChildren<Image>()[1].sprite = i.sprite;
            x.GetComponentInChildren<Text>().text = i.name + " x" + i.count;
            x.transform.position = new Vector3(content.transform.position.x - (Screen.width / 96), (content.transform.position.y - (Screen.height / 16)) - (Screen.height / 8) * index);

            x.GetComponent<Button>().onClick.AddListener(delegate { i.type.use(); });

            index++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
