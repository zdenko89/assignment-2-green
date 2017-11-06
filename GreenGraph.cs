u s i n g   S y s t e m ; 
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ; 
 
 c l a s s   G r e e n G r a p h   :   G r a p h   { 
       
       / /   L i s t   o f   n o d e s   i n   t h i s   g r a p h 
       p r i v a t e   L i s t < N o d e >   n o d e s ; 
 
       / /   A n   a d j a c e n c y   m a t r i x ,   r e c o r d i n g   e d g e s   b e t w e e n   n o d e s 
       / /   E d g e s   F R O M   n o d e   i   a r e   r e c o r d e d   i n   a d j M a t r i x [ i ] 
       / /   E d g e   F R O M   n o d e   i   t o   n o d e   j   i s   r e c o r d e d   i n   a d j M a t r i x [ i ] [ j ] 
       / /   E a c h   i n t   e n t r y   r e c o r d s   t h e   e d g e   c o s t   ( >   - 1 ) 
       / /   I f   e n t r y   i s   0   t h e r e   i s   n o   e d g e   
       p r i v a t e   L i s t < L i s t < i n t > >   a d j M a t r i x ; 
 
       p u b l i c   G r e e n G r a p h ( )   { 
             n o d e s   =   n e w   L i s t < N o d e > ( ) ; 
             a d j M a t r i x   =   n e w   L i s t < L i s t < i n t > > ( ) ; 
       }  
  
  
  
 	 / /   A D D   M I S S I N G   M E T H O D S   H E R E  
  
 	 p u b l i c   v o i d   E d g e C h e c k ( )   / / m e t h o d   f o r   c h e c k i n g   t h e   a d j a c e n c y   m a t r i x   f o r   e d g e s  
 	 { 
 
 	 	 b o o l   e d g e N o d e   =   f a l s e ; 
 
 	 	 f o r   ( i n t   i   =   0 ;   i   <   n o d e s . C o u n t ;   i + + )   / / i t e r a t i n g   h o r i z o n t a l l y ,   t h i s   i s   c h e c k e d   t h r o u g h   t o   t h e   e n d  
 	 	 { 
 	 	 	 f o r   ( i n t   j   =   0 ;   j   <   n o d e s . C o u n t ;   j + + )   / / i t e r a t i n g   v e r t i c a l l y ,   t h i s   i s   c h e c k e d   a f t e r   e a c h   r o w   i s   c h e c k e d  
 	 	 	 {  
 	 	 	 	 i f   ( n o d e s [ i ] [ j ]   >   0 )   / / c h e c k i n g   t h r o u g h   t h e   r o w s   &   c o l u m n s   t o   s e e   i f   t h e r e   i s   a   0  
 	 	 	 	 { 
 	 	 	 	 	 e d g e d N o d e   =   t r u e ;   / /   i f   t h e r e   i s   a   0   t h e n   m a k e   t h i s   b o o l   t r u e 
 
 	 	 	 	 	 i f   ( e d g e N o d e   = =   t r u e ) 
 	 	 	 	 	 { 
 	 	 	 	 	 	 C o n s o l e . W r i t e L i n e ( n o d e s [ i ] [ j ] ) ;     / /   a n d   i f   t h e   b o o l   i s   t r u e   t h e n   p r i n t   t h e   l o c a t i o n   o f   t h e   1 
 	 	 	 	 	 } 
 
 	 	 	 	 }  
 	 	 	 } 
 	 	 } 
 
 	 } 
 
 
 
       p u b l i c   v o i d   W r i t e ( )   { 
             C o n s o l e . W r i t e L i n e ( " G r e e n G r a p h " ) ; 
 
             f o r   ( i n t   i   =   0 ;   i   <   n o d e s . C o u n t ;   i + + )   { 
                   C o n s o l e . W r i t e ( n o d e s [ i ]   +   " :   " ) ; 
 
                   b o o l   f i r s t   =   t r u e ; 
                   f o r   ( i n t   j   =   0 ;   j   <   n o d e s . C o u n t ;   j + + )   { 
                         i f   ( a d j M a t r i x [ i ] [ j ]   >   0 )   { 
                               i f   ( ! f i r s t )   C o n s o l e . W r i t e ( " ,   " ) ; 
                               C o n s o l e . W r i t e ( n o d e s [ j ]   +   " ( "   +   a d j M a t r i x [ i ] [ j ]   +   " ) " ) ; 
                               f i r s t   =   f a l s e ; 
                         } 
                   } 
 
                   C o n s o l e . W r i t e ( " \ n " ) ; 
             } 
       } 
 } 