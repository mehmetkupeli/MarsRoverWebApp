# MarsRover
# Code Review: Mars Rover 
**Part 1** 

Nasa tarafından Marsta bulunan bir platoya robatik gezicilerden oluşan bir ekip indirilecek. İlginç biçimde dikdörtgen olan bu arazi(plato), geziciler tarafından gezilmeli böylece gezicilerin kameraları Dünyaya geri göndermek için çevredeki arazinin tam bir görüntüsünü alabilir. 

Bir gezicinin pozisyonu ve konumu, x ve y koordinatlarını bir kombinasyonu ve dört ana pusula noktasından birini temsil eden bir harf ile temsil edilir (gösterilir). Plato, navigasyonu basitleştirmek için bir ızgaraya bölünmüştür. 

Örnek olarak bir konum 0,0,N olabilir. Bu gezicinin sol alt köşede ve Kuzeye doğru dönük olduğunu gösterir. 
Bir geziciyi kontrol etmek için NASA basit bir harf dizilimi gönderir. Olası harfler L(Left-sol), R(Right-sağ) ve M(Move - ileri) ’dir. 'L' ve 'R', gezicinin mevcut noktasından hareket etmeden sırasıyla 90 derece sola veya sağa dönmesini sağlar. 

M', bir ızgara noktası ileri gitmek ve aynı istikameti korumak anlamına gelir. (x, y)'den doğrudan kuzeydeki karenin (x, y+1) olduğunu varsayın. 

**Input:** 

İlk paremetre platonun sağ üst koordinatlarıdır, sol alt koordinatların 0,0 olduğu varsayılır.Girdinin geri kalanı, konuşlandırılan gezicilere ilişkin bilgilerdir. İlk satır, gezicinin konumunu verir ve ikinci satır, geziciye platoyu nasıl keşfedeceğini söyleyen bir dizi talimattır. Konum, x ve y koordinatlarına ve gezicinin yönüne karşılık gelen iki tam sayıdan ve boşluklarla ayrılmış bir harften oluşur. Sınırsız sayıda gezici tanımlabilecektir. 

Her gezici sırayla tamamlayacak, yani ikinci gezici, birincisi hareket etmeyi bitirene kadar hareket etmeye başlamayacaktır. 
**Output:**

Her gezici için çıktı, nihai koordinatları ve yönü(rota) olmalıdır. 

**Input and Output** 

**Test Input:** 5 5 

1 2 N 

LMLMLMLMM 

3 3 E 

MMRMMRMRRM 

**Expected Output:**

1 3 N 5 1

**Source File :**

[Oymak Group Backend Case.pdf](https://github.com/mehmetkupeli/MarsRover/files/7523721/Oymak.Group.Backend.Case.pdf)

