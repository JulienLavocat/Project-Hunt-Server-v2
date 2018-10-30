# Project-Hunt-Server

*be the hunter, or be hunted*

## Introduction

Project Hunt is a multiplayer FPS where every 30 seconds you got a new target. During this time interval, each kills rewards :
 - Target kill:  5 pts
 - Hunter kill:  3 pts
 - Regular kill: 1 pts

You do not loose any points on death.

## Protocol specifications



### 	1. Connection request

A valid connection request consist of a JWT signed by authentication server. This JWT will contains an Guid and a username.
This JWT is then forwarded to login server through a REST API endpoint to get player informations.

For developpment purposes, we didn't use JWT but plain text-encoded username and Guid and don't check their validy.

### 	2. Chat packet

When server receive a packet with id 100, he retrieve the message from the client, check if he is valid (don't contains banned words, etc...) and build a new packet containing the sender name and message.

- Client :

| ID      | 100                      |
| ------- | ------------------------ |
| **msg** | (string) message to send |

- Server

| ID         | 100                       |
| ---------- | ------------------------- |
| fromLength | (int) size of sender name |
| from       | (string) name of sender   |
| msg        | (string) message          |



## Roadmap

https://trello.com/b/KBeBtyKa/project-hunt-server
