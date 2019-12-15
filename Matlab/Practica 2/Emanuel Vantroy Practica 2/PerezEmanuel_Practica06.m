
Entrada=input('Introduce un numero para el triangulo: ');
S = '*';
T = Entrada;
for i = 1:Entrada
 K = ((T*2)-1);
 T = T -1;
 SC = '*';
    for j = 0:K-2
        SC = strcat(SC,S);
    end 
disp(SC)
end 
