#include <iostream>

int main()
{
    const char* command1 = "cd D:\\MySQL\\MySQL Server 8.0\\bin && mysqldump -u root -p1234 petshop > D:\\e.sql";
    system(command1);
}