using UnityEngine;

public class Type : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int type;
    public int req1;
    public int req2;
    public int req3;
    public int req4;
    public bool isDish;
    public bool isIngredient;
    public bool isChina;
    public SpriteRenderer spriteRenderer;

    public Type()
    {
        type = 0;
        isDish = false;
        isIngredient = false;
        isChina = false;
        spriteRenderer = null;
        req1 = 0;
        req2 = 0;
        req3 = 0;
        req4 = 0;
    }
    public class AllItems : Type
    {
        public class Oko : AllItems
        {
            public Oko()
            {
                type = 1;
                isDish = true;
                isIngredient = false;
                isChina = false;
                req1 = 9;
                req2 = 10;
                req3 = 14;
                req4 = 0;
            }
        }
        public class Moc : AllItems
        {
            public Moc()
            {
                type = 2;
                isDish = true;
                isIngredient = false;
                isChina = false;
                req1 = 9;
                req2 = 14;
                req3 = 0;
                req3 = 0;
            }
        }
        public class Oni : AllItems
        {
            public Oni()
            {
                type = 3;
                isDish = true;
                isIngredient = false;
                isChina = false;
                req1 = 7;
                req2 = 11;
                req3 = 12;
                req4 = 14;
            }
        }
        public class Tam : AllItems
        {
            public Tam()
            {
                type = 4;
                isDish = true;
                isIngredient = false;
                isChina = false;
                req1 = 9;
                req2 = 8;
                req3 = 14;
                req4 = 0;
            }
        }
        public class Mis : AllItems
        {
            public Mis()
            {
                type = 5;
                isDish = true;
                isIngredient = false;
                isChina = false;
                req1 = 7;
                req2 = 10;
                req3 = 13;
                req4 = 0;
            }
        }
        public class Sal : AllItems
        {
            public Sal()
            {
                type = 6;
                isDish = true;
                isIngredient = false;
                isChina = false;
                req1 = 11;
                req2 = 12;
                req3 = 10;
                req4 = 13;
            }
        }
        public class RicUn : AllItems
        {
            public RicUn()
            {
                type = 7;
                isDish = true;
                isIngredient = true;
                isChina = false;
            }
        }
        public class RicCked : AllItems
        {
            public RicCked()
            {
                type = 8;
                isDish = true;
                isIngredient = true;
                isChina = false;
            }
        }
        public class Brd : AllItems
        {
            public Brd()
            {
                type = 9;
                isDish = false;
                isIngredient = true;
                isChina = false;
            }
        }
        public class Egg : AllItems
        {
            public Egg()
            {
                type = 10;
                isDish = false;
                isIngredient = true;
                isChina = false;
            }
        }
        public class Veg : AllItems
        {
            public Veg()
            {
                type = 11;
                isDish = false;
                isIngredient = true;
                isChina = false;
            }
        }
        public class Swd : AllItems
        {
            public Swd()
            {
                type = 12;
                isDish = false;
                isIngredient = true;
                isChina = false;
            }
        }
        public class Fsh : AllItems
        {
            public Fsh()
            {
                type = 13;
                isDish = false;
                isIngredient = true;
                isChina = false;
            }
        }
        public class Plte : AllItems
        {
            public Plte()
            {
                type = 14;
                isDish = false;
                isIngredient = false;
                isChina = true;
            }
        }
        public class Bwl : AllItems
        {
            public Bwl()
            {
                type = 15;
                isDish = false;
                isIngredient = false;
                isChina = true;
            }
        }

    }
    void Start()
    {
        isDish = false;
        isIngredient = false;
        isChina = false;
    }
}