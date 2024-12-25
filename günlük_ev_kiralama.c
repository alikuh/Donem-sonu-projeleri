#include <stdio.h>
#include <stdlib.h>


      int fiyat_hesap(int secim){
      char sehirler[5][50]= {"hatay","antalya","mugla","izmir","istanbul"};
      int fiyat_list[5]= {800,1000,900,600,500};
      int gunluk_fiyat, toplam_fiyat ,gun_sayisi, secilen_sehir, a, b;
      secilen_sehir = sehirler[secim-1];
      gunluk_fiyat = fiyat_list[secim-1];
      while(1){

      printf("eylul ayinin hangi tarihleri arasinda konaklama yapacaksiniz  : ");
      scanf("%d %d" ,&a,&b);
     if (a >= 1 && a <= 30 && b >= 1 && b <= 30 && a < b) {
                  break;
        } else
        {
              printf("Hatali tarih girisi yaptiniz. Lutfen 1 ile 30 arasinda gecerli bir tarih araligi girin.\n");
        }

      }

      gun_sayisi= b-a;
      toplam_fiyat = gun_sayisi * gunluk_fiyat;
      printf("%d gunluk %s tatilinizin tutarý : %d",gun_sayisi,sehirler[secim-1],toplam_fiyat);
      return toplam_fiyat;
}
int rezervasyon(char ad[], char soyad[], char tc[], char telNo[], int secim, int toplam_fiyat,int gun_sayisi){
      char sehirler[5][50]= {"hatay","antalya","mugla","izmir","istanbul"};
      printf("\n************** Rezervasyon Bilgileri **************\n");
    printf("Ad: %s\n", ad);
    printf("Soyad: %s\n", soyad);
    printf("TC Numarasi: %s\n", tc);
    printf("Telefon Numarasi: %s\n", telNo);
    printf("Secilen Sehir: %s\n", sehirler[secim - 1]);
    printf("Konaklama yapacaginiz gun sayisi: %d\n", gun_sayisi);
    printf("Toplam Fiyat: %d TL\n", toplam_fiyat);
    printf("**************************************************\n");

}

int telefon_no_dogrula(char telNo[]) {
    if (strlen(telNo) == 11) {
        for (int i = 0; i < 11; i++) {
            if (!isdigit(telNo[i])) {
                return 0;
            }
        }
        return 1;
    }
    return 0;
}
int tc_no_dogrula(char tc[] ){
      if(strlen(tc) == 11){
            for(int i=0;i<11; i++){
                  if(!isdigit(tc[i])){
                        return 0;
                  }
            }
            return 1;
      }
      return 0;
}

int main()
{
      char ad[50];
      char soyad[50];
      char tc[12];
      char telNo[15];
      char sehirler[5][50]= {"hatay","antalya","mugla","izmir","istanbul"};
      int fiyat_list[5]= {800,1000,900,600,500};
      int secilen_sehir;
      int gunluk_fiyat;
      int gun_sayisi=0;
      int toplam_fiyat=0;
      int secim,i,j;

      printf("***************HOSGELDINIZ*********************\n");
      printf("***************Giris sayfasi*********************\n");
      printf("Ad :  ");
      scanf("%s",&ad);
      printf("soyad : ");
      scanf("%s",&soyad);
      while(1){
      printf("tc numarasi :  ");
      scanf("%s",&tc);
      if(tc_no_dogrula(tc)){
            break;
      }
      else{
            printf("Hatali tc numarasi girdiniz. Lutfen tekrar deneyin.\n");
      }
      }
      while (1) {
        printf("Telefon numaranizi girin (11 haneli, 0 ile baslamali): ");
        scanf("%s", telNo);

        if (telefon_no_dogrula(telNo)) {
            break;
        } else {
            printf("Hatali telefon numarasi girdiniz. Lutfen tekrar deneyin.\n");
        }
    }

      printf("**************Tatil yapmak istediginiz sehri secin***************\n");
      for(i=0;i<5;i++){
                   printf("%d. %s (Gunluk Fiyat: %d TL)\n", i + 1, sehirler[i], fiyat_list[i]);
            }
do {
        printf("***************************************************************\n");
        scanf("%d", &secim);

        if (secim >= 1 && secim <= 5) {
            toplam_fiyat = fiyat_hesap(secim);
            rezervasyon(ad, soyad, tc, telNo, secim, toplam_fiyat,gun_sayisi);
            break;
        }
      else {
            printf("Hatali secim yaptiniz. Lutfen gecerli bir secim yapin (1-5).\n");
        }
    } while (secim < 1 || secim > 5);

    return 0;

}
