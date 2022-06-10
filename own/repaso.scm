(define (sqrt num)
  (define (improve-guess guess) (/ (+ (/ num guess) guess ) 2 )  )
  (define (good-enough? guess) ( < (abs (- (* guess guess) num )) (/ num 10000) ) )
  (define (sqrt-iter guess)
    
    (if (good-enough? guess) 
        guess 
        (sqrt-iter (improve-guess guess)))) 
  (sqrt-iter 1)
  )
(sqrt 64 )


(define (factr x) (if (= x 1)
                      x
                      (* x (factr (- x 1) ))))
         
(define (facti x)
  (define (fact-iter x iters-left)
    (if (= iters-left 1)
        x
        (fact-iter (* x iters-left) (- iters-left 1))))
  (fact-iter 1 x)
  )         
         
;(factr 5)
(facti 5)

;im still worthy