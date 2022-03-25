#include <iostream>

int main()
{
    const char* command2 = "cd D:\\MySQL\\MySQL Server 8.0\\bin && mysql -u root -p1234 petshop < D:\\e.sql";
    system(command2);
}
