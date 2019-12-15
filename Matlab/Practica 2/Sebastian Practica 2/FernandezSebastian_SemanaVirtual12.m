
N=input('Introduce un numero para el triangulo: ');
z = '*';
i=0;
while i<N
 N1 = (((N - i)*2)-1);
 z1 = '*';
 j = 1;
    while j<N1
        z1 = strcat(z1,z);
        j = j+1;
    end 
disp(z1)
i= i+1;
end 
