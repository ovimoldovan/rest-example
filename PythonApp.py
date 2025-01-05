from flask import Flask, request, jsonify

# Create a Flask app
app = Flask(__name__)

# Define a route for the GET API
# http://127.0.0.1:5000/hello
@app.route('/hello', methods=['GET'])
def hello_world():
    text = "Hello world from my python app"
    return jsonify(message=text)

# Define a route for the GET API with a name input
# http://127.0.0.1:5000/hello-name?name=test
@app.route('/hello-name', methods=['GET'])
def hello_name():
    # Get the 'name' query parameter
    name = request.args.get('name')
    text = f"hello, {name}"
    
    # Return a personalized message
    return jsonify(message=text)

# Run the application
if __name__ == '__main__':
    app.run(debug=True)

