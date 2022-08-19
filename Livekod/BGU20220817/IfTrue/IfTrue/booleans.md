# Booleanska värden

true eller false

true = true
false = false
!true = false
!false = true

true == true => true
true == false => false

false == false => true
false == true => false

I ain't done nothing => I have not done nothing => I have done something

----------------------------------------
X=12, Y=7
Om X > 10 och Y>5 => 
   sant och sant => sant

X=11, Y=2
Om X > 10 och Y>5 => x>10 && y>5 =>
   sant   och falskt => falskt

Om X > 10 eller Y>5 => (x>10 || y>5) =>
   sant   eller falskt => sant

             | and &&     | or ||       |
--------------------------------------------------
true         | true       |             | true
true         | false      |             | false
true         |            | true        | true
true         |            | false       | true
false        | true       |             | false
false        | false      |             | false
false        |            | true        | true
false        |            | false       | false

--------------------------------------------------
            | not        |
--------------------------------------------------
true        |            | false     
false       |            | true
