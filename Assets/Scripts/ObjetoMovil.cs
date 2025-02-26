using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoMovil : MonoBehaviour
{

     [SerializeField]
     private GameObject objetoMovil;

     [SerializeField]
     private Transform puntoInicial;

     [SerializeField]
     private Transform puntoFinal;

     [SerializeField]
     private float velocidad;

     [SerializeField]
     private bool isActivo;

     private Vector3 moverHacia;

     // Start is called before the first frame update
     void Start()
     {
          /* 
          Al inicar el juego, definimos un punto objetivo para moverse

          PISTA: recuerda que para acceder al Vector3 de un Transform, debes acceder a la propiedad position 
          */
          moverHacia = puntoFinal.position;
     }

    // Update is called once per frame
    void Update()
    {
        /*
         En cada frame, verificamos si el objeto est� activo
         Si lo est� verificamos si ya lleg� a su destino
         y llamamos al m�todo MoverObjeto para que se mueva
        */

        if (isActivo)
        {
               ComprobarDestino();
               MoverObjeto();
        }
        
    }

     private void ComprobarDestino()
     {
          /*
          Revisamos si ya llegamos al destino, si es as�, cambiamos el punto objetivo

          PISTA: para calcular la distancia entre dos puntos, puedes usar el m�todo Distance de la clase Vector3
          Luego usar if y else para cambiar el punto objetivo dependiendo de cual sea el actual
          */

          if (Vector3.Distance(objetoMovil.transform.position, moverHacia) == 0)
          {
               if (moverHacia == puntoFinal.position)
               {
                    moverHacia = puntoInicial.position;
               }
               else
               {
                    moverHacia = puntoFinal.position;
               }
          }
     }

     private void MoverObjeto()
     {
          /*
           Movemos el objeto hacia el punto objetivo

           PISTA: para mover un objeto, puedes usar el m�todo MoveTowards de la clase Vector3
           */

          objetoMovil.transform.position = Vector3.MoveTowards(objetoMovil.transform.position, moverHacia, velocidad * Time.deltaTime);
     }

}
