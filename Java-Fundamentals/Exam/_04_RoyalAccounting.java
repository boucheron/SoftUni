package com.company;

import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _04_RoyalAccounting {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        HashMap<String, BigDecimal> teamOrder = new HashMap<>();
        HashMap<String, TreeMap<String, BigDecimal[]>> employeeOrder = new HashMap<>();
        List<String> employeesNames = new ArrayList<>();
        Pattern validInput = Pattern.compile("^([a-zA-Z]+);(\\-?\\d+);(\\-?\\d+\\.?\\d*);([a-zA-Z]+)$");

        String command = input.nextLine();
        while (!command.equals("Pishi kuf i da si hodim")) {
            Matcher data = validInput.matcher(command);

            if (data.find()) {
                String employee = data.group(1);
                BigDecimal workHoursPerDay = new BigDecimal(data.group(2));
                BigDecimal dailyPayment = new BigDecimal(data.group(3));
                String team = data.group(4);

                if (!employeesNames.contains(employee)) {
                    employeesNames.add(employee);

                    BigDecimal dailyIncome = (dailyPayment.divide(BigDecimal.valueOf(24.0), 20, RoundingMode.HALF_UP)).multiply(workHoursPerDay);
                    BigDecimal monthlyPaymentEmployee = dailyIncome.multiply(BigDecimal.valueOf(30));

                    if (!teamOrder.containsKey(team)) {
                        teamOrder.put(team, monthlyPaymentEmployee);
                        employeeOrder.put(team, new TreeMap<>());
                    } else {
                        teamOrder.put(team, teamOrder.get(team).add(monthlyPaymentEmployee));
                    }

                    employeeOrder.get(team).put(employee, new BigDecimal[2]);
                    employeeOrder.get(team).get(employee)[0] = workHoursPerDay;
                    employeeOrder.get(team).get(employee)[1] = dailyIncome;
                }
            }

            command = input.nextLine();
        }

        List<Map.Entry<String, BigDecimal>> sortedTeams = new ArrayList<>(teamOrder.entrySet());
        Collections.sort(sortedTeams, (Map.Entry<String, BigDecimal> a1, Map.Entry<String, BigDecimal> a2)
                -> a2.getValue().compareTo(a1.getValue()));

        for (Map.Entry<String, BigDecimal> team : sortedTeams) {
            System.out.println("Team - " + team.getKey());

            List<Map.Entry<String, BigDecimal[]>> sortedEmployees = new ArrayList<>(employeeOrder.get(team.getKey()).entrySet());
            Collections.sort(sortedEmployees, (Map.Entry<String, BigDecimal[]> a1, Map.Entry<String, BigDecimal[]> a2)
                    -> a2.getValue()[1].compareTo(a1.getValue()[1]));
            Collections.sort(sortedEmployees, (Map.Entry<String, BigDecimal[]> a1, Map.Entry<String, BigDecimal[]> a2)
                    -> a2.getValue()[0].compareTo(a1.getValue()[0]));

            for (Map.Entry<String, BigDecimal[]> employee : sortedEmployees) {
                System.out.println("$$$" + employee.getKey() + " - " + employee.getValue()[0] + " - " + employee.getValue()[1].setScale(6, RoundingMode.HALF_UP));
            }

        }

    }
}