resource "aws_lambda_function" "exam_lambda" {
  filename         = "code.zip"
  function_name    = "${var.app_name}-exam_lambda-lambda"
  role             = aws_iam_role.exam_lambda_role.arn
  handler          = var.lambda_handler
  runtime          = var.lambda_runtime
}

resource "aws_iam_role" "exam_lambda_role" {
  name = "exam_lambda-lambda-role"

  assume_role_policy = <<-EOF
  {
    "Version": "2012-10-17",
    "Statement": [
      {
        "Effect": "Allow",
        "Principal": {
          "Service": "lambda.amazonaws.com"
        },
        "Action": "sts:AssumeRole"
      }
    ]
  }
  EOF
}

resource "aws_iam_role_policy_attachment" "bedrock_query_lambda_basic_execution" {
  policy_arn = "arn:aws:iam::aws:policy/service-role/AWSLambdaBasicExecutionRole"
  role       = aws_iam_role.exam_lambda_role.name
}
