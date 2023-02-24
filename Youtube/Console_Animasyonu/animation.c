#include <stdio.h>
#include <windows.h>
#include <string.h>

void delete_char(char*str, int i){
    int len=strlen(str);
    for(;i<len;i++){
        str[i]=str[i+1];
    }
    str[i]='\0';
}
void animate_matrix(char* space, char word_matrix[3][3],char word){
    strcpy(space,"");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            word_matrix[i][j]=word;
        }
    }
    system("cls&&color a");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("%c ", word_matrix[i][j]);
        }
        printf("\n");
    }
    Sleep(40);
    for (int i = 0; i < 10; i++)
    {
        Sleep(40);
        system("cls");
        if (i==3)
        {
            system("color a");
        }
        else if (i<=7)
        {
            system("color e");
        }
        else
        {
            system("color c");
        }
        strcat(space," ");
        for (int j = 0; j < 3; j++)
        {
            printf("%s",space);
            for (int k = 0; k < 3; k++)
            {
                printf("%c ", word_matrix[j][k]);
            }
            printf("\n");
        }
    }
    for(int i = 9;i>=0;i--){
        Sleep(40);
        system("cls");
        if (i==3)
        {
            system("color c");
        }
        else if (i<=7)
        {
            system("color e");
        }
        else
        {
            system("color a");
        }
        delete_char(space,i);
        for (int j = 0; j < 3; j++)
        {
            printf("%s",space);
            for (int k = 0; k < 3; k++)
            {
                printf("%c ", word_matrix[j][k]);
            }
            printf("\n");
        }
    }
    
}


int main(){
    system("cls");
    char word='A';
    int loop = 1;
    printf("Lutfen bir karakter seciniz:");
    scanf("%c",&word);
    if(word=='\n')
        word='A';
    printf("Lutfen animasyon tekrar sayisini giriniz:");
    scanf("%d",&loop);
    if(loop=='\n')
        loop=1;
    char space[100];
    char word_matrix[3][3];
    for (int i = 0; i < loop; i++)
    {
        animate_matrix(space,word_matrix,word);
    }
    
    system("pause");
    return 0;
}