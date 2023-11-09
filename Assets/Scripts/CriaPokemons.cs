using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CriaPokemons : MonoBehaviour
{

    private void Start()
    {

        //Criador de Movimentos
        Move select = new Move("select","select golpe_gremista from ataques" ,20, 0, 20);
        Move update = new Move("update","update brasileirao set campeao = GREMIOOO", 0, 100, 100);
        Move drop = new Move("drop","drop player from existence" ,100, 0, 1);
        Move insert = new Move("insert", "insert dano into player", 40, 0, 40);


       
        ////////////////////////////////////////////////

        //Criador de Listas de ataques dos pokemons
        List<Move> AngoneseMoves = new List<Move>();
        AngoneseMoves.AddRange(new List<Move> { select,update,drop,insert });



        ///////////////////////////////////////////////////

        //Criador dos Pokemons
        Pokemon angonese = new Pokemon("Angonese", 5, 40, 20, 15,AngoneseMoves);



    }
   
    
}
