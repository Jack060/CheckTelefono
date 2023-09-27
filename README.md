# CheckTelefono
Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano ovvero:
- che inizia con +39 (esattamente lungo  13)
- oppure con 0039 (esattamente lungi 14)
- oppure con un 3 (esattamente lungo 10)

Se il numero non viene trovato, ritornare strunga vuota ""

Ad esempio.
Se arriva "05417373", "3367726712",  "778823"
Tornare "3367726712"

Se arriva "33677267", "33677232",  "778823"
Tornare ""

Se arriva "", "05417723",  "+391231231234"
Tornare "+391231231234"

Se arriva "3", "05417723",  "00391231231230"
Tornare ""

etc
<details>
<summary>controllo del numero con il prefisso '+39'</summary>

```c#
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
```
utilizzo il primo for per caricare il primo numero di telefono nell'array "numero", inizializzo la variabile "prefisso" per poi caricarla nel secondo for scorrendo i primi tre caratteri del vettore "numero"
</details>
<details>
<summary>controllo del numero con il prefisso '0039'</summary>

```c#
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
```
</details>
<details>
<summary>controllo del numero con il prefisso '3' e il return vuoto</summary>

```c#
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
```
</details>
