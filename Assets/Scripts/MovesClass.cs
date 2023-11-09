using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Move
    {
        public Move(string name, string descricao, int power, int regen, int velocidade)
        {
            this.name = name;
            this.descricao = descricao;
            this.power = power;
            this.regen = regen;
            this.velocidade = velocidade;
        }

        public string name;
        public string descricao;
        public int power;
        public int regen;
        public int velocidade;

        
    }

