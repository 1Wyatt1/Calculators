      * Stupid fucking calculator
      * i know cobol and i will use it
      * fuck yeah, i know cobol like a gigachad
      * - superleaf1995

      *
      * use some mainframe to run this calulcator
      * idk what jcl you have to put but basically you need to run it

      * you also need a supercomputer to run this piece of software
      * and a half-million USD dollar's worth of licenses
       IDENTIFICATION DIVISION.
       PROGRAM-ID. STUPID-CALCULATOR.

       ENVIRONMENT DIVISION.
       INPUT-OUTPUT SECTION.
      * Nothing here kiddo :), no files, just sadness

       DATA DIVISION.
       WORKING-STORAGE SECTION.
      * funny temporal
       01 WS-OPERATOR PIC X(1).
       01 WS-A PIC 9(16)V9(4).
       01 WS-B PIC 9(16)V9(4).

       PROCEDURE DIVISION.
       ENTRY_PARA.
           DISPLAY 'Operator:'.
           ACCEPT WS-OPERATOR.
           DISPLAY 'Number1:'.
           ACCEPT WS-A.
           DISPLAY 'Number2:'.
           ACCEPT WS-B.

           DISPLAY 'Formula ', WS-A, ' ', WS-OPERATOR, ' ', WS-B.

      * code duplication because limine memes
           EVALUATE WS-OPERATOR
              WHEN '+' ADD WS-A TO WS-B
              WHEN '-' SUBTRACT WS-A FROM WS-B
              WHEN '*' MULTIPLY WS-A BY WS-B
              WHEN 'x' MULTIPLY WS-A BY WS-B
              WHEN 'X' MULTIPLY WS-A BY WS-B
              WHEN '/' DIVIDE WS-A INTO WS-B
              WHEN OTHER STOP RUN
           END-EVALUATE.

           DISPLAY 'Result: ', WS-B.
           STOP RUN.
