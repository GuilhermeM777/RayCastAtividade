# RayCastAtividade

## Descrição
Esse trabalho foi feito para aplicar as aplicações aplicadas em sala de aula sobre RayCast e Destroy, feito por Guilherme Matos de Oliveira e Cauã Magalhães Leão

## Ray Cast
# ![image](https://github.com/GuilhermeM777/RayCastAtividade/assets/127865701/598864d5-a489-4a10-8ecd-69a0bd01a133)
Nas primeiras linhas do código eu primeiro, eu coloquei um transform target para dizer qual o objeto que o raycast vai mirar, assim quando for por script, depois só colocar qual objeto é para o raycast destruir.

# ![image](https://github.com/GuilhermeM777/RayCastAtividade/assets/127865701/450d4594-5ba8-46aa-98fa-8e042f3e40fb)
RaycastHit hit 
O RaycastHit é usado para acertar alguma coisa, e embaixo inseri um If para se o raycast acertar o objeto selecionado como target, vai fazê-lo ser destruir, nas sobrecargas coloquei o trasform.position para definir o ponto de origem do raio, e o outro refere-se à posição do objeto ao qual este script está anexado, ou seja,  objeto que está olhando para o outro objeto('target'). O normalized garante que ele tenha comprimento 1, o que significa que o raio terá apenas a direção, não importando a distância.s informações sobre o objeto atingido serão armazenadas nesta variável 'hit', se o contrário acontecer a variável só vai conter informações padrões, indicando que o raio não acertou nada.

# ![image](https://github.com/GuilhermeM777/RayCastAtividade/assets/127865701/a419f042-6131-4372-8d58-cbf161b3cdfe)
Esta linha faz parte de uma estrutura condicional if e está verificando se o objeto atingido pelo raio (hit.transform) é o mesmo que o objeto alvo (target) que estamos interessados em verificar se está no campo de visão do objeto atual.
 - 'hit.transform': Esta linha retorna o componente 'Transform' do objeto atingido pelo raio. O objeto atingido pode ser qualquer objeto no cenário que o raio interceptou.
 - 'target': Esta é a variável que contém a referência ao objeto que estamos interessados em verificar se está no campo de visão do objeto atual.

# ![image](https://github.com/GuilhermeM777/RayCastAtividade/assets/127865701/d26460ab-b845-4020-ac49-29995c11a260)
Esta linha também faz parte de uma estrutura condicional if e está verificando se a distância entre a posição do objeto atual e a posição do objeto alvo (target) é menor ou igual a uma determinada distância (destroyDistance). Se essa condição for verdadeira, significa que o objeto atual está a uma distância igual ou menor que a destroyDistance do objeto alvo, e então é o momento de destruir o objeto alvo.
 -'Vector3.Distance': Este é um método estático da classe 'Vector3' em Unity, que calcula a distância entre dois pontos no espaço tridimensional. No caso, ele está sendo usado para calcular a distância entre a posição do objeto atual ('transform.position') e a posição do objeto alvo ('target.position').
 -'transform.position': Este é o vetor que representa a posição do objeto ao qual este script está anexado, ou seja, o objeto atual.
 - 'target.position': Este é o vetor que representa a posição do objeto alvo que estamos monitorando.
 - 'destroyDistance': Esta é uma variável que define a distância máxima em que queremos que o objeto alvo seja destruído

# ![image](https://github.com/GuilhermeM777/RayCastAtividade/assets/127865701/55155cf8-5f91-4bfd-b19f-22c0889ae6e8)
Esta linha de código utiliza a função Destroy para remover o objeto alvo (target) da cena. Vamos analisar mais detalhadamente:
 -'target': Esta é a referência ao objeto que queremos destruir. No contexto do código, 'target' é o objeto que estamos monitorando para verificar se está dentro de uma certa distância e, se estiver, queremos destruí-lo.
 -'gameObject': 'target.gameObject' é a referência ao 'GameObject' associado ao componente target. Isso é necessário porque a função Destroy espera receber o 'GameObject' que queremos destruir, e não apenas o componente Transform ou qualquer outro componente.
 -'Destroy': Esta é uma função fornecida pelo Unity que remove um objeto da cena. Quando 'Destroy' é chamado, o objeto associado é marcado para destruição e será removido da cena no final do frame atual.

 ## Adicionais
 Por várias complicações, só consegui pegar o notebook da minha mãe no qual uso para programar, hoje mesmo, então, tive muitos problemas com as versões do Unity e a Asset Store que um simplesmente não queria mudar de versão e outro não levava os assets pro unity, eu baixava, tentava abrir pelo unity e não estava indo, por isso a falta de assets e a versão estar desatualizada, descupla Aline, eu fiquei mais de 2 horas tentando resolver o unity, a parte de programar não foi díficil, não tomou tempo, mas essa fiquei muito tempo e estressado, então pensei que poderia fazer assim, além disso o gitbash não estava passando o projeto pro unity, então vou anexar o link para o google drive aqui abaixo. Desculpa pelos distúrbios e um Bom Dia, Boa tarde ou noite, pra quando estiver corrigindo isso <3 (Desculpe pelo código de movimentação, por que eu não sei o que deu nesse especificamente que ele começou a ficar bugado assim).

 ##Link do Jogo
https://drive.google.com/drive/folders/1uR5AytLmhGQGCWyXvDILUHkTWyNMtaap?usp=drive_link
(Pode usar ambos, qual preferir)
https://drive.google.com/file/d/1KgQqd1O3RrlhGJNvkEmzTJQL30ljXh2h/view?usp=sharing




