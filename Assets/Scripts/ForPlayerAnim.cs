using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPlayerAnim : MonoBehaviour
{

    
    Animator anim;

    

  


    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    public void animWithoutWeapons()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if ((anim.GetBool("RunL") == false) && (anim.GetBool("RunR") == false) && (anim.GetBool("Sprint") == false))
            {
                anim.SetBool("RunF", true);
                anim.SetBool("Stay", false);
                anim.SetBool("Sprint", false);

            }


        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            if (anim.GetBool("StrafeR") == false && anim.GetBool("StrafeL") == false)
            {
                anim.SetBool("RunF", false);
                anim.SetBool("Sprint", false);
                anim.SetBool("Stay", true);


            }

        }



        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            anim.SetBool("RunF", false);
            anim.SetBool("RunR", true);
            anim.SetBool("Stay", false);
            anim.SetBool("StrafeR", false);

        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            anim.SetBool("RunF", false);
            anim.SetBool("RunL", true);
            anim.SetBool("Stay", false);
            anim.SetBool("StrafeL", false);

        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("RunR", false);

            if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.D))
            {
                anim.SetBool("Stay", true);
            }
            else if (Input.GetKeyUp(KeyCode.D) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("RunF", true);
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("StrafeR", true);
            }


        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("RunL", false);

            if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.A))
            {
                anim.SetBool("Stay", true);
            }
            else if (Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("RunF", true);
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("StrafeL", true);
            }



        }


        if (Input.GetKey(KeyCode.A))
        {
            if (anim.GetBool("RunL") == false)
            {
                anim.SetBool("StrafeL", true);
                anim.SetBool("Stay", false);
            }

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (!Input.GetKey(KeyCode.W))
            {
                anim.SetBool("StrafeL", false);
                anim.SetBool("Stay", true);
            }
            else
            {
                if (Input.GetKey(KeyCode.D))
                {
                    anim.SetBool("StrafeL", false);
                    anim.SetBool("RunR", true);
                }
                else
                {
                    anim.SetBool("StrafeL", false);
                    anim.SetBool("RunF", true);
                }
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (anim.GetBool("RunR") == false)
            {
                anim.SetBool("StrafeR", true);
                anim.SetBool("Stay", false);
            }

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (!Input.GetKey(KeyCode.W))
            {
                anim.SetBool("StrafeR", false);
                anim.SetBool("Stay", true);
            }
            else
            {
                if (Input.GetKey(KeyCode.A))
                {
                    anim.SetBool("StrafeR", false);
                    anim.SetBool("RunL", true);
                }
                else
                {
                    anim.SetBool("StrafeR", false);
                    anim.SetBool("RunF", true);
                }
            }
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
            {
                anim.SetBool("RunF", true);
                anim.SetBool("RunR", false);
                anim.SetBool("RunL", false);
                anim.SetBool("StrafeL", false);
                anim.SetBool("StrafeR", false);
            }
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
            {
                anim.SetBool("RunB", true);
                anim.SetBool("RunBL", false);
                anim.SetBool("RunBR", false);
                anim.SetBool("StrafeL", false);
                anim.SetBool("StrafeR", false);
            }
            else
            {
                anim.SetBool("StrafeL", false);
                anim.SetBool("StrafeR", false);
                anim.SetBool("Stay", true);
            }


        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Stay", false);
            anim.SetBool("RunB", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("Stay", true);
            anim.SetBool("RunB", false);
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            anim.SetBool("RunB", false);
            anim.SetBool("RunBR", true);
            anim.SetBool("Stay", false);
            anim.SetBool("StrafeR", false);

        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            anim.SetBool("RunB", false);
            anim.SetBool("RunBL", true);
            anim.SetBool("Stay", false);
            anim.SetBool("StrafeL", false);

        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("RunBR", false);

            if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.D))
            {
                anim.SetBool("Stay", true);
            }
            else if (Input.GetKeyUp(KeyCode.D) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("RunB", true);
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("StrafeR", true);
            }


        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("RunBL", false);

            if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.A))
            {
                anim.SetBool("Stay", true);
            }
            else if (Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("RunB", true);
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("StrafeL", true);
            }



        }




    }

    public void animWithAk()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if ((anim.GetBool("RunLR") == false) && (anim.GetBool("RunRR") == false))
            {
                anim.SetBool("RunFR", true);
                anim.SetBool("StayR", false);
               

            }


        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            if (anim.GetBool("StrafeRR") == false && anim.GetBool("StrafeLR") == false)
            {
                anim.SetBool("RunFR", false);
                anim.SetBool("StayR", true);


            }

        }



        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            anim.SetBool("RunFR", false);
            anim.SetBool("RunRR", true);
            anim.SetBool("StayR", false);
            anim.SetBool("StrafeRR", false);

        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            anim.SetBool("RunFR", false);
            anim.SetBool("RunLR", true);
            anim.SetBool("StayR", false);
            anim.SetBool("StrafeLR", false);

        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("RunRR", false);

            if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.D))
            {
                anim.SetBool("StayR", true);
            }
            else if (Input.GetKeyUp(KeyCode.D) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("RunFR", true);
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("StrafeRR", true);
            }


        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("RunLR", false);

            if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.A))
            {
                anim.SetBool("StayR", true);
            }
            else if (Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("RunFR", true);
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("StrafeLR", true);
            }



        }


        if (Input.GetKey(KeyCode.A))
        {
            if (anim.GetBool("RunLR") == false)
            {
                anim.SetBool("StrafeLR", true);
                anim.SetBool("StayR", false);
            }

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (!Input.GetKey(KeyCode.W))
            {
                anim.SetBool("StrafeLR", false);
                anim.SetBool("StayR", true);
            }
            else
            {
                if (Input.GetKey(KeyCode.D))
                {
                    anim.SetBool("StrafeLR", false);
                    anim.SetBool("RunRR", true);
                }
                else
                {
                    anim.SetBool("StrafeLR", false);
                    anim.SetBool("RunFR", true);
                }
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (anim.GetBool("RunRR") == false)
            {
                anim.SetBool("StrafeRR", true);
                anim.SetBool("StayR", false);
            }

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (!Input.GetKey(KeyCode.W))
            {
                anim.SetBool("StrafeRR", false);
                anim.SetBool("StayR", true);
            }
            else
            {
                if (Input.GetKey(KeyCode.A))
                {
                    anim.SetBool("StrafeRR", false);
                    anim.SetBool("RunLR", true);
                }
                else
                {
                    anim.SetBool("StrafeRR", false);
                    anim.SetBool("RunFR", true);
                }
            }
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
            {
                anim.SetBool("RunFR", true);
                anim.SetBool("RunRR", false);
                anim.SetBool("RunLR", false);
                anim.SetBool("StrafeLR", false);
                anim.SetBool("StrafeRR", false);
            }
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
            {
                anim.SetBool("RunBRif", true);
                anim.SetBool("RunBLR", false);
                anim.SetBool("RunBRR", false);
                anim.SetBool("StrafeLR", false);
                anim.SetBool("StrafeRR", false);
            }
            else
            {
                anim.SetBool("StrafeL", false);
                anim.SetBool("StrafeR", false);
                anim.SetBool("StayR", true);
            }


        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("StayR", false);
            anim.SetBool("RunBRif", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("StayR", true);
            anim.SetBool("RunBRif", false);
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            anim.SetBool("RunBRif", false);
            anim.SetBool("RunBRR", true);
            anim.SetBool("StayR", false);
            anim.SetBool("StrafeRR", false);

        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            anim.SetBool("RunBRif", false);
            anim.SetBool("RunBLR", true);
            anim.SetBool("StayR", false);
            anim.SetBool("StrafeLR", false);

        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("RunBRR", false);

            if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.D))
            {
                anim.SetBool("StayR", true);
            }
            else if (Input.GetKeyUp(KeyCode.D) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("RunBRif", true);
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("StrafeRR", true);
            }


        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("RunBLR", false);

            if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.A))
            {
                anim.SetBool("StayR", true);
            }
            else if (Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("RunBRif", true);
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("StrafeLR", true);
            }



        }
    }
    // Update is called once per frame
    void Update()
    {
        animWithAk();

    }
        
        

        

}
 