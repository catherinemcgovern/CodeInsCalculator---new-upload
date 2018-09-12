* Recipe for Insurance Calculator
             * DESCRIPTION: 
                The Insurance Calculator Program will take personal information and calculate their insurance rate based on their age, gender, and credit score.
                INGREDIENTS:
                int gender = 0;
                int valid gender = 0;
                int cScore = 0;
                int age;
                int final_insurance_rate
                Instructions:

                Intro:
                    Ask the user if they want to get a quote. If so start GetQuote Method

                1.	Start with $500 as base insurance rate
                
                2.  Take credit score, age, and gender inputs from user and store values into respective variables
                        Each of these input however is validated as the program progresses and the insurance premium base amount
                        is affected by each of the inputs, including these requirements:
                            a.  If the user is male and between the ages of 18 and 24 then the premium increases by $250.
                            b.  If the user is female and between the ages of 18 and 24 then the premium increases by $100.
                            c. Users between the age of 24 and 30 have a premium increase of $50.
                                --- and so forth, other ages have other premium increases
                            d if credit score is <500, increase total by $200, if 500<x<600, increase by $50  
                 3.	Present final_insurance_rate for user.
                COMPLETENESS:
                Take input values correctly and that values are properly validated
                Make sure If statements are computing correctly
                Make sure final values are adding correctly
                Make sure presentation is correct and clean. 
                Make sure that the flow of the program is smooth
                