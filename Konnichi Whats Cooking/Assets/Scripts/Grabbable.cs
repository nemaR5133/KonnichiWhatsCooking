using UnityEngine;


public enum ItemTypes
{
    iTinvalid = -1,
    iTokonomiyaki,
    iTmochi,
    iTpancake,
    iTonigiri,
    iTsando,
    iTsalad,
    iTriceC,
    iTriceU,
    iTbread,
    iTegg,
    iTveggie,
    iTweed,
    iTfish,
    iTbatter,
    iTbowl
}


public class Grabbable : MonoBehaviour
{
    public ItemTypes itemTypes = ItemTypes.iTinvalid;
    public int type_;
    public bool isDish;
    public bool isIngredient;
    public bool isServable;
    public bool isChina;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       switch(itemTypes)
        {
            case ItemTypes.iTinvalid:
                break;
            case ItemTypes.iTokonomiyaki:
                isDish = true;
                isIngredient = false;
                isChina = false;
                isServable = true;
                break;
            case ItemTypes.iTmochi:
                isDish = true;
                isIngredient = false;
                isChina = false;
                isServable = true;
                break;
            case ItemTypes.iTpancake:
                isDish = true;
                isIngredient = false;
                isChina = false;
                isServable = true;
                break;
            case ItemTypes.iTonigiri:
                isDish = true;
                isIngredient = false;
                isChina = false;
                isServable = true;
                break;
            case ItemTypes.iTsando:
                isDish = true;
                isIngredient = false;
                isChina = false;
                isServable = true;
                break;
            case ItemTypes.iTsalad:
                isDish = true;
                isIngredient = false;
                isChina = false;
                isServable = true;
                break;
            case ItemTypes.iTriceC:
                isDish = false;
                isIngredient = true;
                isChina = false;
                isServable = false;
                break;
            case ItemTypes.iTriceU:
                isDish = false;
                isIngredient = true;
                isChina = false;
                isServable = false;
                break;
            case ItemTypes.iTbread:
                isDish = false;
                isIngredient = true;
                isChina = false;
                isServable = false;
                break;
            case ItemTypes.iTegg:
                isDish = false;
                isIngredient = true;
                isChina = false;
                isServable = false;
                break;
            case ItemTypes.iTveggie:
                isDish = false;
                isIngredient = true;
                isChina = false;
                isServable = false;
                break;
            case ItemTypes.iTweed:
                isDish = false;
                isIngredient = true;
                isChina = false;
                isServable = false;
                break;
            case ItemTypes.iTfish:
                isDish = false;
                isIngredient = true;
                isChina = false;
                isServable = false;
                break;
            case ItemTypes.iTbatter:
                isDish = false;
                isIngredient = true;
                isChina = false;
                isServable = false;
                break;
            case ItemTypes.iTbowl:
                isDish = false;
                isIngredient = false;
                isChina = true;
                isServable = false;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
