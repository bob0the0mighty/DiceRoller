#ifndef DICE_H
#define DICE_H

// dice roller public API

#ifdef __cplusplus
extern "C" {
#endif

// the maximum size of a die that may be rolled
#define DICE_MAX_SIDES 100000
// the maximum number of dice that may be rolled (including extra dice from exploding dice/rerolls)
#define DICE_MAX_DICE 100
// the maximum complexity (nestedness) of the expression tree; note that certain dice constructs use multiple levels
#define DICE_MAX_RECURSE 20

// syntax errors


// runtime errors
#define DICE_ERROR_DIVZERO (-1)
#define DICE_ERROR_MAXDICE (-2)
#define DICE_ERROR_MAXRECURSE (-3)
#define DICE_ERROR_MAXSIDES (-4)
// trying to roll a die with less than 1 side
#define DICE_ERROR_MINSIDES (-5)
// trying to roll less than 1 die
#define DICE_ERROR_MINDICE (-6)



#ifdef __cplusplus
}
#endif

#endif
