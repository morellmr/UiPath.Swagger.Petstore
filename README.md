# Example UiPath Implementation of the Swagger Petstore API

## Overview

This project demonstrates how to wrap an API in a UiPath library project, turning it into reusable activities for low-code workflows. It's a partial implementation of the [Swagger Petstore API](https://petstore.swagger.io/), meant as an internal example for our team—no plans to expand or publish it.

## Approach

- We use UiPath code source files to define the API's data models.
- Regular UiPath workflows handle the activity implementations.
- The goal is to balance solid coding practices with ease of use in a low-code environment.

## Getting Started

- Open the project in UiPath Studio.
- Review the workflows in the `Pet/`, `Store/`, and `User/` folders.
- Run the tests in `_Tests/` to see examples in action.
