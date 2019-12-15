
a=input('introduzca el valor de a: ') ; 
b=input('introduzca el valor de b: ') ;
cont=input('introduzca el numero de interraciones: ');
fun=input('introduzca la funcion f(x)= ');
f=inline(fun);
for k=1:cont
    c=(a+b)/2
    e=abs((b-a)/2);
    A(k,:)=[k a b c f(c) e];
    if f(a)*f(c)<0
        b=c;
    else
        a=c;
    end
end
        
