
N=input('Introduce un numero para el triangulo: ');
s2 = '*';
i=0;
J = N;
while i<N
 K = ((J*2)-1);
 asterico = '*';
 F = 1;
    while F<K
        asterico = strcat(asterico,s2);
        F = F+1;
    end 
disp(asterico)
i= i+1;
J = J -1;
end 
