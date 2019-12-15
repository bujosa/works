
x=input('Digite su funcion: '); 
a=input('introduzca el valor de a: ') ; 
b=input('introduzca el valor de b: ') ;
t=input('Introduzca el nivel de tolerancia: '); 
f=inline(x); 

xai=a; 
xbi=b; 
tol=t;
i=1; 
ea(1)=100;

pase = true;

if f(xai)*f(xbi)<0 
    xa(1)=xai; 
    xb(1)=xbi; 
    xr(1)=(xa(1)+xb(1))/2; 
    while abs (ea(i))>=tol 
        if f(xa(i))*f(xr(i))<0 
            xa(i+1)=xa(i); 
            xb(i+1)=xr(i); 
        end
        if f(xa(i)) *f(xr(i))>0 
            xa(i+1)=xr(i); 
            xb(i+1)=xb(i); 
        end
        xr(i+1)=(xa(i+1)+xb(i+1))/2; 
        ea(i+1)=abs((xr(i+1)-xr(i))/(xr(i+1))*100); 
        i=i+1;
        r=num2str(xr(i));
        
            if pase == true
            disp('Has hecho el primer calculo sigues o detiene');
            disp('1. Sigo');
            disp('2. detengo el loop');
            pase = false;
            opcion = input('Digita opcion: ');
               if opcion == 2
                break;
               end
            end   
    end
    r=num2str(xr(i)); 
    disp(r); 
    y = eval(x);
    z = xa:0.5:xb;
    plot(z,y);
else
    disp('NO EXISTE UNA RAIZ EN ESTE INTERVALO'); 
end