using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventWhenTouched : MonoBehaviour
{
    bool showGUI = false;
    bool hitMiddleGround = false;
    bool hitPalmerFront = false;
    bool hitPalmerBack = false;
    bool hitRhodesSeal = false;
    bool hitBriggsFront = false;
    bool hitBriggsBack = false;
    bool hitLibraryFront = false;
    bool hitLibraryBack = false;
    bool hitDiehlStatue = false;
    bool hitTheRat = false;
    bool hitOakAlley = false;
    bool hitPresOffice = false;
    bool hitLynxLair = false;
    bool hitStarCeiling = false;

    // Start is called before the first frame update
    void Start()
    {
        //showGUI = false;
    }

    void showBox()
    {
        showGUI = true;
        CancelInvoke("hideBox");
        Invoke("hideBox", 9.0F);
    }

    void hideBox()
    {
        showGUI = false;
        hitMiddleGround = false;
        hitPalmerFront = false;
        hitPalmerBack = false;
        hitRhodesSeal = false;
        hitBriggsFront = false;
        hitBriggsBack = false;
        hitLibraryFront = false;
        hitLibraryBack = false;
        hitDiehlStatue = false;
        hitTheRat = false;
        hitOakAlley = false;
        hitPresOffice = false;
        hitLynxLair = false;
        hitStarCeiling = false;
    }

    private void OnGUI()
    {
        //Vector2 pivotPoint = new Vector2(Screen.width / 2, Screen.height / 2);
        //GUIUtility.RotateAroundPivot(-90, pivotPoint);

        GUIStyle infoStyle = new GUIStyle();
        infoStyle.fontSize = 40;
        //GUI.skin.box.wordWrap = true; 

        int boxWidth = 550;
        int boxHeight = 300;

        int xAlt = (Screen.width / 2) - (boxWidth / 2);
        int yAlt = (Screen.height - boxHeight) - 50;

        //Screen Width 750 so % 7, height 1334 % 4.5

        Texture2D bg = Texture2D.whiteTexture;
        infoStyle.normal.background = bg;


        //GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), " Briggs Hall: computer science\n------------------------------------------\n Newly renovates, this building\n   hosts classrooms, offices,\n a large meeting space, and a\n        virtual reality lab!", infoStyle);

        //infoStyle.normal.textColor = Color.black;
        //GUI.color = Color.white;un
        if (showGUI)
        {
            if (hitMiddleGround)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), "             Middle Ground\n------------------------------------------\n    A 24-hour study space and\n  perfect place to meet friends,\n    the Middle Ground also \n    serves Starbucks coffee!", infoStyle);
            }
            else if (hitPalmerFront)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), " Palmer Hall: language and lit\n------------------------------------------\n  Home to the English, foreign\nlanguage, and Greek & Roman\n       studies departments.\n        Renovated in 2010", infoStyle);
            }
            else if (hitPalmerBack)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), " Palmer Hall: language and lit\n------------------------------------------\n  Home to the English, foreign\nlanguage, and Greek & Roman\n       studies departments.\n        Renovated in 2010", infoStyle);
            }
            else if (hitRhodesSeal)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), "               Rhodes Seal\n------------------------------------------\n            Don’t step here! \nRumor is that if a student steps \n      on the seal, they won’t \n           graduate on time! ", infoStyle);
            }
            else if (hitBriggsFront)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), " Briggs Hall: computer science\n------------------------------------------\n Newly renovated, this building \n   hosts classrooms, offices,\n a large meeting space, and a\n        virtual reality lab!", infoStyle);
            }
            else if (hitBriggsBack)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), " Briggs Hall: computer science\n------------------------------------------\n Newly renovated, this building \n   hosts classrooms, offices,\n a large meeting space, and a\n        virtual reality lab!", infoStyle);
            }
            else if (hitLibraryFront)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), "        Paul Barret Jr. Library\n------------------------------------------\n    The “heart of the campus” \nfeatures a wonderful collection\n  of books, classrooms, study \n  spaces, and computer labs. ", infoStyle);
            }
            else if (hitLibraryBack)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), "        Paul Barret Jr. Library\n------------------------------------------\n    The “heart of the campus” \nfeatures a wonderful collection\n  of books, classrooms, study \n  spaces, and computer labs. ", infoStyle);
            }
            else if (hitDiehlStatue)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), "               Diehl Statue\n------------------------------------------\n          artist: Edwin Rust \n     material: bronze\n Charles Diehl was the college \n  president from 1917 to 1948. ", infoStyle);
            }
            else if (hitTheRat)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), "  Catherine Burrow Refectory \n------------------------------------------\n   Open 7 days a week, this is \n        the campus cafeteria. \n   Students call it “The Rat” in \nreference to the statue outside. ", infoStyle);
            }
            else if (hitOakAlley)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), "                  Oak Alley \n------------------------------------------\nThese trees were transplanted \n   from the original campus in \nClarksville. Back then, Rhodes \n    was called Southwestern. ", infoStyle);
            }
            else if (hitPresOffice)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), "        President Hass’ Office\n------------------------------------------\n   In 2017, we welcomed our \n  new president Marjorie Hass. \n She is our 20th president, and\nRhodes’s first female president. ", infoStyle);
            }
            else if (hitLynxLair)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), "              Lynx Lair Pub\n------------------------------------------\n  The lair is open for lunch and \n   dinner, seven days a week \n   from 11:30am to 11:00pm. \npizza - deli - beer - sandwiches ", infoStyle);
            }
            else if (hitStarCeiling)
            {
                GUI.Box(new Rect(xAlt, yAlt, boxWidth, boxHeight), "        Library Apse Ceiling\n------------------------------------------\nThis lovely study spot features \n   a ceiling painted with stars. \nSpecifically, it depicts the Lynx\n constellation, sun, and moon. ", infoStyle);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount > 0) //timer
        //{ 
        //  Debug.Log("TOUCHED"); //MAKE GLOBE OBJECT INPUT, NOT JUST GENERAL INPUT
        //}

        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("something hit"); // this part working, touch registering

                if (raycastHit.transform.tag == "middleGround")
                {
                    hitMiddleGround = true;
                    showBox();
                }
                //new tags
                else if (raycastHit.transform.tag == "palmerFront")
                {
                    hitPalmerFront = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "palmerBack")
                {
                    hitPalmerBack = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "rhodesSeal")
                {
                    hitRhodesSeal = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "briggsFront")
                {
                    hitBriggsFront = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "briggsBack")
                {
                    hitBriggsBack = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "libraryFront")
                {
                    hitLibraryFront = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "libraryBack")
                {
                    hitLibraryBack = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "diehlStatue")
                {
                    hitDiehlStatue = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "theRat")
                {
                    hitTheRat = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "oakAlley")
                {
                    hitOakAlley = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "presOffice")
                {
                    hitPresOffice = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "lynxLair")
                {
                    hitLynxLair = true;
                    showBox();
                }
                else if (raycastHit.transform.tag == "starCeiling")
                {
                    hitStarCeiling = true;
                    showBox();
                }
            }
        }
    }
}
