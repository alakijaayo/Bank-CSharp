# Bank-Tech-C#

My first major foray into learning how to use C#. Based on a tech test that was given to us, I am going to try and complete the Bank Tech Test using the new language I am learning. Testing will be done with NUnit.

## Specification

### Requirements

* You should be able to interact with your code via a REPL like IRB or the JavaScript console.  (You don't need to implement a command line interface that takes input from STDIN.)
* Deposits, withdrawal.
* Account statement (date, amount, balance) printing.
* Data can be kept in memory (it doesn't need to be stored to a database or anything).

### Acceptance criteria

**Given** a client makes a deposit of 1000 on 10-01-2012  
**And** a deposit of 2000 on 13-01-2012  
**And** a withdrawal of 500 on 14-01-2012  
**When** she prints her bank statement  
**Then** she would see

```
date || credit || debit || balance
14/01/2012 || || 500.00 || 2500.00
13/01/2012 || 2000.00 || || 3000.00
10/01/2012 || 1000.00 || || 1000.00
```

## User Stories

Whilst working on the project, I came up with user stories as a good soundboard to figure out how I the account should work from a users standpoint and to also help flesh out how I would want my account interface to work. These were the initial user stories that were used:

- As a client, so I can see how much money I have, I would like to check my balance
- As a client, so I can save my money, I would like to make a deposit
- As a client, so I can get my money from my account, I would like to make a withdraw
- As a client, so I can know my monthly financial transactions, I would like to view a bank statement
- As a client, so that I know when transactions were made in my account, I would like to view a timestamp of transactions
- As a client, so that I know when I am about to go over my limit, I would like a warning informing me I have no available funds
