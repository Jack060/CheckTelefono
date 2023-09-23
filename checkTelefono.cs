using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {
        
        string numero="";
        for (int i = 0; i < input.Length; i++)
        {
            numero = input[i];
            string prefisso = "";
            
            for(int j = 0; j < 3; j++){
                prefisso = prefisso + numero[j];
            }
            if(prefisso == "+39"){
                if(numero.Length==13){
                    return numero;
                }
            }

        }
        
        for(int i = 0; i< input.Length; i++){
            numero = input[i];
            string prefisso = "";
            
            for(int j = 0; j < 4; j++){
                prefisso = prefisso + numero[j];
            }
            if(prefisso == "0039"){
                if(numero.Length==14){
                    return numero;
                }
            }
        }

        for(int i = 0; i< input.Length; i++){
            numero = input[i];

            if(numero[i] == '3'){
                if(numero.Length==10){
                    return numero;
                }
            }
        }
        return "";
    }
}