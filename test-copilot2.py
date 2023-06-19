def factorial(n):
    if n == 0:
        return 1
    else:
        return n * factorial(n-1)

#function to find the sum of the digits of a number
def sum_of_digits(n):
    if n == 0:
        return 0
    else:
        return n % 10 + sum_of_digits(n // 10)

#fibonacci sequence
def fibonacci(n):
    if n == 0:
        return 0
    elif n == 1:
        return 1
    else:
        return fibonacci(n-1) + fibonacci(n-2)

#fetch data from an API
import requests
def get_data(url):
    response = requests.get(url)
    return response.json()
