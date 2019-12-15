
% Marco Loinaz

M=input('Digite la N del triangulo: ');

for i = 0:M-1
 Formula = (((M - i)*2)-1);
 sumstring = '*';
    for ii = 2:Formula
        sumstring = strcat(sumstring,'*');
    end 
disp(sumstring)
end 
