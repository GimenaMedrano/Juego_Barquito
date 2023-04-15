int [,] tablero=new int[5,5];

void palos_crear_tablero(){
    for(int f=0; f<tablero.GetLength(0); f++{
         for(int c=0; f<tablero.GetLength(0); c++{
        tablero[f,c]=0;
    } 
    }
}
void paso2_colocar_barco(){
    tablero[4,3]=1;
    tablero[1,1]=1;
    tablero[2,1]=1;
    tablero[4,4]=1;
}
void paso3_imprimir_tablero(){
    string caracter_a_imprimir="";
      for(int f=0; f<tablero.GetLength(0); f++{
         for(int c=0; f<tablero.GetLength(0); c++{
      switch(tablero[f,c]){
          case 0;
          caracter_a_imprimir="-"
          break;
          case 1:
          caracter_a_imprimir="B"
          break;
          case -1:
          caracter_a_imprimir="*"
          break;
          case -2:
          default:
          caracter_a_imprimir="-"
          break;
      }
        Console.Write(caracter_a_imprimir+"");
    } 
    console.Write;
    }
}


void paso4_ingreso_cordenadas(){
    int fila,columana=0;
    Consolesole.Clear
    do{
        Consolesole.Write("ingrese la fila");
        fila=ConvertToInt32(Consolesole.ReadLine());
        Consolesole.Write("ingrese la columna");
        columna=ConvertToInt32(Consolesole.ReadLine());
        if(tablero[fila,columna]==1){
            console.Beep();
            tablero[fila,columna]=-1;
        }
        else {
            tablero[fila,columna]=-2;
        }
            console.Clear;
            paso3_imprimir_tablero

    }while(true);
    
}
