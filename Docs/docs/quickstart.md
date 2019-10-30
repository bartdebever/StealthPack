---
id: gettingstarted
title: Quickstart
---

Within this document the essentials of the pack from the guard side of things are stated.
This document goes over the most basic of interaction between the different scripts
and how the scripts were intended to be used.

## The scripts

This is a basic overview of some of the essential scripts within the package.
These scripts will be explained in a little more detail within the rest of this
document. For full detailed explanations of these scripts, there is a "More info"
link at the bottom of the basic explanation.

| Script | Use case |
|---------|-----------------|
| Guard | Base scripts that connects together other scripts and inherits from the BasicStateMachine. |
| MonoMovementPattern | Defines a set number of `Vector3`s that the guard will go to. |
| MonoMovementHandler | Inheritable script that is for moving the guard to places. |
| BasicStateMachine | Allows for an easy implementation of an alert system with different levels |
| GuardData | Statistics that are unique to that guard. Can be used to alter speed or vision distance.|
| SuspiciousObject| Defines an object or component as suspicious and can be seen by a guard.|
| ISaveableScript | Allows for a script to be quick loaded and saved if set up correctly. |

## Guard

## MonoMovementPattern

### Use case

### Code example

### BasicMovementPattern

## MonoMovementHandler

## BasicStateMachine

## GuardData

## SuspiciousObject

## ISaveableScript
